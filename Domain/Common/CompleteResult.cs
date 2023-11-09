namespace Domain.Models.Common
{
    public class CompleteResult<T>
    {
        public List<T> result { get; set; }
        public int returnValue { get; set; }
    }
}
