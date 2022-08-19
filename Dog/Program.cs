// Задача про собаку из курса "Введение в программирование"

int count = 0;
int distance = 1000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;

while(distance > 10)
{
    int friend = new Random().Next(0, 2);
    if(friend == 0)
    {
        int time = distance / (first_friend_speed + dog_speed);
        distance = distance - (first_friend_speed + second_friend_speed) * time;
        count = count + 1;
    }

    if(friend == 1)
    {
        int time = distance / (second_friend_speed + dog_speed);
        distance = distance - (first_friend_speed + second_friend_speed) * time;
        count = count + 1;
    }
}

Console.WriteLine($"Собака пробежит {count} раз");

// Оно работает, ошибок не выдает, но мне кажется, считает неверно:))))

