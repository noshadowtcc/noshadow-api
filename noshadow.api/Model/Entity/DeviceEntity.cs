using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace noshadow.api.Model.Entity
{
    public class DeviceEntity
    {
        public Guid Id { get; set; }
        
        public Guid DeviceName { get; set; }
        
        public Guid Serial { get; set; }
        
        public Guid MacAddress { get; set; }
        
        public Guid UserId { get; set; }
        
        [ForeignKey("UserId")]
        public UserEntity User { get; set; }
    }
}