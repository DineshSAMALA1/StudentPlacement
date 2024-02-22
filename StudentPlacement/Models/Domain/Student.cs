namespace StudentPlacement.Models.Domain
{
    public class Student
    {

        public Guid Id { get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }  
       
        public int Percentage {  get; set; }
    }
}
