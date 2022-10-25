namespace PraticandoPoo.Student
{
    public class Student
    {
        public Student(string name, double note1, double note2, double note3)
        {
            this.Name = name;
            this.Note1 = note1;
            this.Note2 = note2;
            this.Note3 = note3;
        }
        public string Name { get; set; }
        public double Note1 { get; set; }
        public double Note2 { get; set; }
        public double Note3 { get; set; }
        public double average { get; set; }
        public string GrabMedia()
        {
            this.average = (this.Note1 + this.Note2 + this.Note3) / 3;
            if (average >= 7) return this.Name + " tem média: " + this.average.ToString("F") + " portanto passou de ano.";          
            return this.Name + " tem média: " + this.average.ToString("F") + " portanto não passou de ano.";
        }
    }
}