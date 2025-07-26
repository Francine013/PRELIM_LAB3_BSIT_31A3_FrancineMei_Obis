namespace PRELIM_LAB3_A3_FRANCINE_OBIS.Models
{
    public class BasedEntity
    {
        public string firstName { get; set; }
        public string lastName  { get; set; }
        public string middleName  {get; set;}
        public DateTime birthDate { set; get; }
        public string FullName => $"{firstName} {lastName}";

        public int  GetAge(){
    return DateTime.Now.Year-birthDate.Year; }

    }
}

