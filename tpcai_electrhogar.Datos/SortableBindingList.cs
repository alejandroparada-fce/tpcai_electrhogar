using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpcai_electrhogar.Datos;

public class SortableBindingList<T> : BindingList<T>
{
    private bool isSorted;
    private ListSortDirection sortDirection;
    private PropertyDescriptor sortProperty;
    private List<ClienteEnt> listaClientes;

    public SortableBindingList(List<ClienteEnt> listaClientes)
    {
        this.listaClientes = listaClientes;
    }

    protected override bool SupportsSortingCore => true;
    protected override bool IsSortedCore => isSorted;

    protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
    {
        var items = (List<T>)this.Items;
        var property = typeof(T).GetProperty(prop.Name);

        if (property != null)
        {
            items.Sort((x, y) =>
            {
                var valueX = property.GetValue(x);
                var valueY = property.GetValue(y);

                int result;

                if (valueX is IComparable comparableX && valueY != null)
                {
                    result = comparableX.CompareTo(valueY);
                }
                else if (valueX == null && valueY != null)
                {
                    result = -1;
                }
                else if (valueX != null && valueY == null)
                {
                    result = 1;
                }
                else
                {
                    result = 0;
                }

                return direction == ListSortDirection.Ascending ? result : -result;
            });

            sortProperty = prop;
            sortDirection = direction;
            isSorted = true;
        }
        else
        {
            isSorted = false;
        }

        OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
    }

    protected override void RemoveSortCore()
    {
        isSorted = false;
        sortProperty = null;
        sortDirection = ListSortDirection.Ascending;
    }

    protected override ListSortDirection SortDirectionCore => sortDirection;

    protected override PropertyDescriptor SortPropertyCore => sortProperty;
}