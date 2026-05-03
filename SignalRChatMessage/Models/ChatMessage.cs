using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRChatMessage.Models
{
    [Table("chatmessage")]
    public partial class ChatMessage
    {
        [Key]
        public int id { get; set; }

        public string messagetxt { get; set; }

        [StringLength(150)]
        public string username { get; set; }
    }
}
