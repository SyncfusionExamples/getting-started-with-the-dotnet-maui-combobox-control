using MAUIExample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIExample
{
    public class ControlViewModel
    {
        public ObservableCollection<ControlModel> SocialMedia { get; set; }
        public ControlViewModel()
        {
            SocialMedia = new ObservableCollection<ControlModel> {
                new ControlModel() { Name = "Facebook", ID = 0 },
                new ControlModel() { Name = "Telegram", ID = 1 },
                new ControlModel() { Name = "YouTube", ID = 2 },
                new ControlModel() { Name = "Instagram", ID = 3 },
                new ControlModel() { Name = "Twitter", ID = 4 },
                new ControlModel() { Name = "Google Plus", ID = 5 },
                new ControlModel() { Name = "WhatsApp", ID = 6 },
                new ControlModel() { Name = "Televzr", ID = 7 },
                new ControlModel() { Name = "Tik Tok", ID = 8 }
            };
        }
    }
}
