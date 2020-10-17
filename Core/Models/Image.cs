namespace Core.Models
{
    public class Image
    {
        #region Properties

        public string Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Descripition { get; set; }
        public ImageLinks Links { get; set; }

        #endregion
    }
}
