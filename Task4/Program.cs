long num;
long capacity = 1;

long n = 19876568923324;

while(n > capacity) {
    capacity *= 10;
}

capacity /= 10;

while(capacity > 0) {
    num = n / capacity;
    Console.Write($"{num}, ");
    n %= capacity;
    capacity /= 10;
}

