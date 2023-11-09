namespace Course.Entities
{
    class Department
    {

        public string Name { get; set; }
        public string SurName { get; set; }

        public Department() { }

        public Department(string name, string surName)
        {
            Name = name;
            SurName = surName;
        }
    }
}
