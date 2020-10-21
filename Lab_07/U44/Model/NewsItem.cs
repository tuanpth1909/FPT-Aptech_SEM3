using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U44.Model
{
    public class NewsItem
    {
        public int Id { get; set; }

        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsManager
    {
        public static void GetNews(
            string category,
            ObservableCollection<NewsItem> newsItems)

        {
            var allItems = getNewsItems();

            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Tuan", Headline = "Pham", Subhead = "Aptech", DateLine = "21/10/2001", Image = "1.jpg" });
            items.Add(new NewsItem() { Id = 2, Category = "Tuan", Headline = "Pham", Subhead = "Aptech", DateLine = "21/10/2001", Image = "2.jpg" });
            items.Add(new NewsItem() { Id = 3, Category = "Tuan", Headline = "Pham", Subhead = "Aptech", DateLine = "21/10/2001", Image = "3.jpg" });
            items.Add(new NewsItem() { Id = 4, Category = "Tuan", Headline = "Pham", Subhead = "Aptech", DateLine = "21/10/2001", Image = "4.jpg" });
            items.Add(new NewsItem() { Id = 5, Category = "Tuan", Headline = "Pham", Subhead = "Aptech", DateLine = "21/10/2001", Image = "5.jpg" });
            items.Add(new NewsItem() { Id = 6, Category = "Tuan", Headline = "Pham", Subhead = "Aptech", DateLine = "21/10/2001", Image = "6.jpg" });
            items.Add(new NewsItem() { Id = 7, Category = "Tuan", Headline = "Pham", Subhead = "Aptech", DateLine = "21/10/2001", Image = "7.jpg" });
            items.Add(new NewsItem() { Id = 8, Category = "Tuan", Headline = "Pham", Subhead = "Aptech", DateLine = "21/10/2001", Image = "8.jpg" });
            items.Add(new NewsItem() { Id = 9, Category = "Tuan", Headline = "Pham", Subhead = "Aptech", DateLine = "21/10/2001", Image = "9.jpg" });

            return items;
        }
    }
}
