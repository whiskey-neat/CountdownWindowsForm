using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownWindowsForm
{
    public class PlayerModel
    {
        public PlayerModel(int score, string username)
        {
            this.Score = score;
            this.Username = username;
        }

        public int Score { get; set; }
        public string Username { get; set; }
    }
}
