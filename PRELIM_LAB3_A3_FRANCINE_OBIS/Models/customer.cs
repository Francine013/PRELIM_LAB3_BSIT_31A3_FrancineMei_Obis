namespace PRELIM_LAB3_A3_FRANCINE_OBIS.Models
{
    public class customer : BaseEntity, IDescribeable
    {
        public int CustomerId { get; set; }

        public override string GetDescription()
        {
            return $"Regular Customer, {GetFullName()} {GetAge()} {CustomerId}";
        }
    }
}
