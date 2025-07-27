namespace PRELIM_LAB3_A3_FRANCINE_OBIS.Models
{
    public class VIPCustomer : customer
    {
        public bool IsVip { get; set; }

        public override string GetDescription()
        {
            return $"VIP Customer, {GetFullName()} {GetAge()} {CustomerId}";
        }
    }
}
