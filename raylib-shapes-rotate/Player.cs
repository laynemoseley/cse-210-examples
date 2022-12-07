using Raylib_cs;
using System.Numerics;
class Player: GameObject {

    Texture2D texture;

    int rotation = 0;

    public Player() {
        
        var image = Raylib.LoadImage("link.png");
        this.texture = Raylib.LoadTextureFromImage(image);
        Raylib.UnloadImage(image);
    }

    public Rectangle Rect() {
        return new Rectangle(Position.X, Position.Y, 50, 53);
    }

    public override void Move()
    {
        // Reset the velocity every frame unless keys are being pressed
        var velocity = new Vector2();
        var movementSpeed = 3;

        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
            velocity.X = movementSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
            velocity.X = -movementSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
            velocity.Y = -movementSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
            velocity.Y = movementSpeed;
        }

        Velocity = velocity;

        base.Move();
        rotation += 1;
    }

    public override void Draw() {
        var rect = this.Rect();
        var origin = new Vector2(rect.width / 2, rect.height / 2);
        var source = new Rectangle(0, 0, rect.width, rect.height);
        Raylib.DrawTextureTiled(this.texture, source, rect, origin, rotation, 1.0F, Color.WHITE);
    }
}