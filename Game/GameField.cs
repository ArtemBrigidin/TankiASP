namespace Tanki_ASP.NET.Models
{
    public class GameField
    {
        public int FieldWidth => 15;
        public int FieldHeight => 15;

        public GameCellTile[][] Map { get; private set; }

        public GameField()
        {
            Map = InitializeMap();
            GenerateMap();
            PlaceTank(0, 14);  // Добавляем танк на позицию (14, 0)
        }

        private void GenerateMap()
        {
            GenerateBrickCells(60);
            GenerateBadRock();

            Map[FieldHeight / 2][^1] = GameCellTile.FriendlyBase;
            Map[FieldHeight / 2][0] = GameCellTile.EnemyBase;
        }

        private void GenerateBadRock()
        {
            for (int row = 2; row < FieldHeight - 2; row += 2)
            {
                for (int column = 2; column < FieldWidth - 2; column += 2)
                {
                    Map[row][column] = GameCellTile.BadRock;
                }
            }
        }

        private void GenerateBrickCells(int fillPercent)
        {
            Random random = new Random();

            for (int row = 0; row < FieldHeight; row++)
            {
                for (int column = 0; column < FieldWidth; column++)
                {
                    int randomValue = random.Next(0, 100);
                    if (randomValue <= fillPercent)
                    {
                        Map[row][column] = GameCellTile.Brick;
                    }
                }
            }
        }

        private GameCellTile[][] InitializeMap()
        {
            GameCellTile[][] map = new GameCellTile[FieldHeight][];

            for (int counter = 0; counter < FieldHeight; counter++)
            {
                map[counter] = new GameCellTile[FieldWidth];
                Array.Fill(map[counter], GameCellTile.Empty);
            }
            return map;
        }

        private void PlaceTank(int row, int column)
        {
            if (row >= 0 && row < FieldHeight && column >= 0 && column < FieldWidth)
            {
                Map[row][column] = GameCellTile.Tank;
            }
        }
    }
}