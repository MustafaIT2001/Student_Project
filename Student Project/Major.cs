namespace Student_Project
{
    public class Major
    {
        // Private field for the Major ID
        private int dId;

        // Property for the Major ID with validation in the setter
        public int ID
        {
            get
            {
                return dId;
            }
            set
            {
                if (value > 3) // Ensure the ID is greater than 3
                {
                    dId = value;
                }
            }
        }

        // Readonly property for the Major Name
        public string sMajorName { get; }

        // Property for the Doctor's Name
        public string sDrName;

        // Method to add a major (currently not implemented)
        public void Add()
        {
            // Implementation for adding a major would go here
        }

        // Method to remove a major (currently not implemented)
        public void Remove()
        {
            // Implementation for removing a major would go here
        }

        // Constructor to initialize the Major with a name and a doctor's name
        public Major(string sMajorName, string sDrName)
        {
            this.sMajorName = sMajorName;
            this.sDrName = sDrName;
        }

        // Copy constructor to create a new Major from an existing one
        public Major(Major myMajor)
        {
            ID = myMajor.dId;
            this.sMajorName = myMajor.sMajorName;
            this.sDrName = myMajor.sDrName;
        }
    }
}