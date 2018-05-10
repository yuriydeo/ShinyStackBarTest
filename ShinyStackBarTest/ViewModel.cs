using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShinyStackBarTest
{
    public class ViewModel
    {
        public ViewModel()
        {
            PopulateData();

        }

        private void PopulateData()
        {
            _floors = new ObservableCollection<Floor>();
            for (int i = 4; i > 0; i--)
            {
                Floor floor = new Floor($"floor{i}");
                for (int j = 1; j < 8 - i; j++)
                {
                    Room room = new Room($"room{i}{j}", (i * 95.5 * j % 7) * 10.0, (RoomType)((i + j) % 4));
                    floor.Rooms.Add(room);
                }
                _floors.Add(floor);
            }
        }

        private ObservableCollection<Floor> _floors;
        public ObservableCollection<Floor> Floors { get { return _floors; } }
    }
}
