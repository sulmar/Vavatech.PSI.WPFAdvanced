using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.PSI.WPF.Models
{
    // PM> Install-Package PropertyChanged.Fody

    public abstract class Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }

    // IEditableObject 
    // https://msdn.microsoft.com/pl-pl/library/system.componentmodel.ieditableobject(v=vs.110).aspx


}
