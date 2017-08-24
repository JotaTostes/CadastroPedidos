using System.Collections.Generic;
using System.Linq;

namespace CadastroPedidos.Core.Infra
{
    public class Notification
    {
        private readonly List<string> _notifications;

        public Notification()
        {
            _notifications = new List<string>();
        }

        public void Add(string notification)
        {
            _notifications.Add(notification);
        }

        public bool HasNotification => _notifications != null && _notifications.Any();

        public IEnumerable<string> GetNotification => _notifications;
    }
}
