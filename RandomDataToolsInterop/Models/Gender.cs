namespace RandomDataToolsInterop.Models
{
    public class Gender
    {
        public string Code { get; set; }
        
        public string Name { get; set; }

        /// <summary>
        /// Мужской пол.
        /// </summary>
        public static readonly Gender Male = new()
        {
            Code = "man",
            Name = "Мужчина"
        };

        /// <summary>
        /// Женский пол.
        /// </summary>
        public static readonly Gender Female = new()
        {
            Code = "woman",
            Name = "Женщина"
        };

        public override string ToString() => Name;
    }
}