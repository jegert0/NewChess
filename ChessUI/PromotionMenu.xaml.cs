using ChessLogic;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChessUI
{
    /// <summary>
    /// Interaction logic for PromotionMenu.xaml
    /// </summary>
    public partial class PromotionMenu : UserControl
    {
        public event Action<PieceType> PieceSelected;
        public PromotionMenu(Player player)
        {
            InitializeComponent();

            QueenImg.Source = Images.GetImage(player, PieceType.Queen);
            BishopImg.Source = Images.GetImage(player, PieceType.Bishop);
            KnightImg.Source = Images.GetImage(player, PieceType.Knight);
            RookImg.Source = Images.GetImage(player, PieceType.Rook);
        }

        public void QueenImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PieceSelected?.Invoke(PieceType.Queen);

        }

        public void BishopImg_MouseDown(object sender, MouseButtonEventArgs e) 
        {
            PieceSelected?.Invoke(PieceType.Bishop);
        }

        public void KnightImg_MouseDown(object sender, MouseButtonEventArgs e) 
        {
            PieceSelected?.Invoke(PieceType.Knight);
        }

        public void RookImg_MouseDown(object sender, MouseButtonEventArgs e) 
        {
            PieceSelected?.Invoke(PieceType.Rook);
        }
    }
}
