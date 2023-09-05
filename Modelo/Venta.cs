namespace Modelo
{
    public class Venta
    {
        //atributos
        public String name { set; get; }
        public String RUC { set; get; }
        public DateTime Fecha { set; get; }
        public DateTime Hora { set; get; }
        public String producto { set; get; }
        public int cantidad { set; get; }

        //metodos
        public double AsignaPrecio()
        {
            switch (producto)
            {
                case "Lavadora": return 1500;
                case "Refrigeradora": return 3500;
                case "Licuadora": return 500;
                case "Extractora": return 150;
                case "Radiograbadora": return 750;
                case "DVD": return 100;
                case "BluRay": return 250;
            }
            return 0;
            
        }

        public double CalculaSubtotal()
        {
            return AsignaPrecio() * cantidad;
        }
    }
}