
namespace SebastianWS.DTO
{
    public class Airport
    {
        #region Fields

        private string name;
        private int id;

        #endregion

        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        #endregion

        public Airport() { }

        public Airport(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}