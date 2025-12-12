namespace ApiCapacitacion
{
    public class Postgressqlconfiguration
    {
        private readonly string _conexionstring;

        public Postgressqlconfiguration(string conexionstring)
            => _conexionstring = conexionstring;

        public string GetConnection()
            => _conexionstring;
    }
}