namespace dotnetcrud.Entities
{
    public class Student
    {
        public int Id{ get; set;}
        public required string Name { get; set;}
        public string FirstName {get; set;} = string.Empty; // never null
        public string LastName {get; set;} = string.Empty;
        public string Place {get; set;} = string.Empty;
    }
}