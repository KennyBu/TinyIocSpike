namespace Models
{
    public class King : IPerson
    {
        private readonly Alignment _alignment;
        private readonly IGloat _gloat;

        public King(IGloat gloat)
        {
            _gloat = gloat;
            _alignment = Alignment.Good;
        }

        public string Name { get; set; }
        public Alignment Alignment { get; private set; }
        public string Gloat()
        {
            return string.Concat(_gloat.Gloat(),string.Format(" and I am {0}",_alignment));
        }
    }
}