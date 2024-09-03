using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GamePro
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public int score;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // เพิ่มการอัปเดตคะแนน
            UpdateScore(10); // เพิ่มคะแนน 10 ทุกครั้งที่ Update เรียกใช้

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            // แสดงคะแนน
            DrawScore();

            base.Draw(gameTime);
        }

        // เมธอดใหม่ที่ใช้ในการเพิ่มคะแนน
        public void UpdateScore(int points)
        {
            score += points;
        }

        // เมธอดใหม่ที่ใช้ในการแสดงคะแนน
        private void DrawScore()
        {
            // ตัวอย่างการแสดงคะแนน (โค้ดจริงจะต้องใช้ SpriteBatch และข้อความที่โหลดจาก Content)
            System.Console.WriteLine($"Score: {score}");
        }
    }
}