using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_PracticaFinal_POO
{
    public class Notificar_Cambios : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
    
        public void OnProperty([CallerMemberName] string PropertyName = null )
        {
            this.PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( PropertyName ) );
        }
    }
}
