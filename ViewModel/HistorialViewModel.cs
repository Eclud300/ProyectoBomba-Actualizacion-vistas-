using System.Collections.ObjectModel;

namespace ProyectoBomba.ViewModel
{
    public class HistorialViewModel
    {
        public ObservableCollection<HistorialItem> HistorialData { get; set; }

        public HistorialViewModel()
        {
            // Puedes agregar tus datos de ejemplo aquí
            HistorialData = new ObservableCollection<HistorialItem>
            {
                new HistorialItem { Dia = "01/01/2025", Porcentaje = "10", Tiempo = "01:30" },
                new HistorialItem { Dia = "02/01/2025", Porcentaje = "9", Tiempo = "00:45" },
                new HistorialItem { Dia = "03/01/2025", Porcentaje = "23", Tiempo = "03:33" },
                new HistorialItem { Dia = "04/01/2025", Porcentaje = "5", Tiempo = "01:56" },
                new HistorialItem { Dia = "05/01/2025", Porcentaje = "7", Tiempo = "02:53" },
                new HistorialItem { Dia = "06/01/2025", Porcentaje = "11", Tiempo = "05:38" },
                new HistorialItem { Dia = "07/01/2025", Porcentaje = "2", Tiempo = "01:40" }
            };
        }
    }

    public class HistorialItem
    {
        public string Dia { get; set; }
        public string Porcentaje { get; set; }
        public string Tiempo { get; set; }
    }
}
