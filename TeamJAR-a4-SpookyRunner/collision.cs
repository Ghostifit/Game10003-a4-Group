using Game10003;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;


public class collision
{
    Vector2 position = new Vector2(0, 400);
    Vector2 size = new Vector2(800, 200);
    Vector2 point = new Vector2(40, 360);
    float radius = 40;
    Vector2 gravity = new Vector2(0, 10);
    Vector2 speed = new Vector2(0, 0);
    Vector2 obstaclePosition = new Vector2(650, 350);
    Vector2 obstacleSpeed = new Vector2(-50, 0);
    Vector2 obstacleGravity = new Vector2(0, 0);
    public static bool End = false;
    public void Colllsion()
    {
    }
    public void Setup()
    {

        Window.TargetFPS = 60;
        Window.SetSize(800, 600);
    }
    public void Update()
    {
        //write score
        Vector2 textPosition = new Vector2(10, 10);
        Vector2 textSize = new Vector2(100, 30);
        Text.Draw("Score: 0", textPosition);

        // draw platform
        Draw.LineSize = 2;
        Draw.FillColor = Color.Black;
        Draw.Rectangle(0, 400, 800, 600);
        //draw objects
        Draw.FillColor = Color.Yellow;
        Draw.LineSize = 2;
        Draw.Circle(point, radius);
        //draw obstacle
        Draw.FillColor = Color.Red;
        Draw.LineSize = 2;
        Draw.Square(obstaclePosition, 50);

        speed += gravity * Time.DeltaTime;
        point += speed * 7 * Time.DeltaTime;

        obstacleSpeed += obstacleGravity * Time.DeltaTime;
        obstaclePosition += obstacleSpeed * Time.DeltaTime;
        //user input
        if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
        {
            speed.Y -= 25;
        }
        //platform collision
        //convert position and size to edges
        float leftEdge = position.X;
        float rightEdge = position.X + size.X;
        float topEdge = position.Y;
        float bottomEdge = position.Y + size.Y;
        //collision check

        bool isPointInRectangle = (point.X >= leftEdge && point.X <= rightEdge &&
                       point.Y >= topEdge && point.Y <= bottomEdge);

        // calculate the distance from the circle's center to this point
        float distanceX = position.X;
        float distanceY = position.Y;




    }

}

