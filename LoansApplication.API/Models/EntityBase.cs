namespace LoansApplication.API.Models
{
    public class EntityBase : IDisposable, IEquatable<int>
    {
        protected EntityBase() { }

        public int Id { get; set; }
        public DateTime CreateAt { get; private set; } = DateTime.Now;
        public DateTime? UpdateAt { get; private set; } = null;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool Equals(int other)
        {
            return Id == other;
        }
    }
}
