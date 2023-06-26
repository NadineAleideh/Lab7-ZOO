using Lab7_ZOO;

namespace TestLab7_ZOO
{
    public class UnitTest1
    {
        //Tests of Horse
        [Fact]
        public void Horse_Sound_Test()
        {
            // Arrange
            var horse = new Horse("Bella", 5, 500, "Brown");

            // Act
            string sound = horse.Sound();

            // Assert
            Assert.Equal("Neigh!", sound);
        }

        [Fact]
        public void Horse_GiveBirth_Test()
        {
            // Arrange
            var horse = new Horse("Lily", 7, 600, "Brown");

            // Act
            string sound = horse.GiveBirth();

            // Assert
            Assert.Equal("The horse gives birth to a foal.", sound);
        }

        //Tests of Dog
        [Fact]
        public void Dog_Sleep_Test()
        {
            // Arrange
            var dog = new Dog("Max", 3, 20, "White");

            // Act
            string sleepAction = dog.Sleep();

            // Assert
            Assert.Equal("The dog is lying down and resting.", sleepAction);
        }

        [Fact]
        public void Dog_Sound_Test()
        {
            // Arrange
            var dog = new Dog("Buddy", 2, 12, "Black");

            // Act
            string Sound = dog.Sound();

            // Assert
            Assert.Equal("Woof woof!", Sound);
        }

        //Tests of Cat
        [Fact]
        public void Cat_Domesticated_Test()
        {
            // Arrange
            var cat = new Cat("Zizi", 3, 3, "White");

            // Act
            string LiveInsideHomesAction = cat.LiveInsideHomes();

            // Assert
            Assert.Equal("People love cats to cuddle with them.", LiveInsideHomesAction);
        }

        [Fact]
        public void Cat_Sound_Test()
        {
            // Arrange
            var cat = new Cat("Sally", 2, 4, "Gray");

            // Act
            string Sound = cat.Sound();

            // Assert
            Assert.Equal("Meow!", Sound);
        }

        //Tests of Snake
        [Fact]
        public void Sanke_LayEggs_Test()
        {
            // Arrange
            var snake = new Snake("Sniky", 1, 3, "Green");

            // Act
            string LayEggsAction = snake.LayEggs();

            // Assert
            Assert.Equal("The snake lays eggs.", LayEggsAction);
        }

        [Fact]
        public void Snaket_Sound_Test()
        {
            // Arrange
            var snake = new Snake("Loli",1, 3, "Green");

            // Act
            string Sound = snake.Sound();

            // Assert
            Assert.Equal("Hiss!", Sound);
        }


        //Tests of Turtle
        [Fact]
        public void Turtle_Sunbathe_Test()
        {
            // Arrange
            var turtle = new Turtle("Taco", 120, 9, "Green");

            // Act
            string SunbatheAction = turtle.Sunbathe();

            // Assert
            Assert.Equal("The turtle basks in the sun to warm up.", SunbatheAction);
        }

        [Fact]
        public void Turtle_Sleep_Test()
        {
            // Arrange
            var turtle = new Turtle("Flippy", 100, 12, "Black");

            // Act
            string sleepAction = turtle.Sleep();

            // Assert
            Assert.Equal("The turtle finds a safe spot and rests.", sleepAction);
        }
    }
}