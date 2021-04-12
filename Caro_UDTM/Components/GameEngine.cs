using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_UDTM.Components
{
    class GameEngine
    {

        #region Hàm đánh giá thắng thua

        // Quy ước:
        // 2 là X thắng
        // 1 là O thắng
        // 0 là hòa
        private int checkWinner(Board caroBoard)
        {
            if (GameLogic.getScore(caroBoard, true, false) >= GameConstant.WIN_SCORE) return 2;
            if (GameLogic.getScore(caroBoard, false, true) >= GameConstant.WIN_SCORE) return 1;

            return 0;
        }

        #endregion


        public TableLayoutPanel getCaroBoardLayout(TableLayoutPanel mainTablePanel)
        {
            return (TableLayoutPanel)mainTablePanel.Controls.OfType<TableLayoutPanel>().ToArray()[0];
        }


    }
}
