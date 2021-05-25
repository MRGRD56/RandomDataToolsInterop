namespace RandomDataToolsInterop.Models
{
    public class ApiSettings
    {
        /// <summary>
        /// Использовать единственный экземпляр HttpClient. <br/>
        /// Если false - для каждого запроса будет создаваться новый экземпляр. <br/>
        /// Рекомендуется: false.
        /// </summary>
        public bool UseSingleHttpClient { get; set; } = false;

        /// <summary>
        /// Автоматически использовать задержку между запросами. <br/>
        /// Рекомендуется: false.
        /// </summary>
        public bool UseDelayBetweenRequests { get; set; } = false;

        /// <summary>
        /// Задержка между запросами в миллисекундах. <br/>
        /// Рекомендуется: 1000.
        /// </summary>
        public int RequestsInterval { get; set; } = 1000;

        /// <summary>
        /// Количество возможных одновременных запросов. <br/>
        /// Ограничение действует только при включённом параметре UseDelayBetweenRequests. <br/>
        /// Рекомендуется: 1.
        /// </summary>
        public int ParallelRequestsCount { get; set; } = 1;
    }
}