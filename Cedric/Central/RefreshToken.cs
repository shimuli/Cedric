using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class RefreshToken
    {
        public int RefreshTokenId { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string JwtId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
