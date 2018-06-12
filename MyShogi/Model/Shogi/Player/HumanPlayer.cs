﻿using MyShogi.Model.Shogi.Core;

namespace MyShogi.Model.Shogi.Player
{
    /// <summary>
    /// ユーザーの操作を受け付けるクラスを
    /// Player派生クラスとして実装してある。
    /// </summary>
    public class HumanPlayer : Player
    {
        public PlayerTypeEnum PlayerType
        {
            get { return PlayerTypeEnum.Human; }
        }

        public string Name { get; set; }

        public string DisplayName { get { return Name; } }

        /// <summary>
        /// このプレイヤーが指した指し手
        /// </summary>
        public Move BestMove { get; set; }

        /// <summary>
        /// このプレイヤーのponderの指し手
        /// </summary>
        public Move PonderMove { get; set; }

        public void OnIdle()
        {
        }
    }
}
