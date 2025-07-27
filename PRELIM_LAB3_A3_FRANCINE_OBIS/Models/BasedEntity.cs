namespace PRELIM_LAB3_A3_FRANCINE_OBIS.Models
{
    public abstract class BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }

        public string GetFullName() => $"{FirstName} {MiddleName} {LastName}";

        public int GetAge()
        {
            var today = DateTime.Today;
            int age = today.Year - BirthDay.Year;
            if (BirthDay > today.AddYears(-age)) age--;
            return age;
        }

        public virtual string GetDescription()
        {
            return $"{GetFullName()} {GetAge()}";
        }
    }
}
