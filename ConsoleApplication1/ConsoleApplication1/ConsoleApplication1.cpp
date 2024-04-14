#include <iostream>

int gcd(int a, int b) {
    while (a != b) {
        if (a > b)
            a -= b;
        else
            b -= a;
    }
    return a;
}

int readNumber(const std::string& name) {
    int number;
    while (true) {
        std::cout << "Wprowadź liczbę " << name << ": ";
        if (std::cin >> number && number >= 0)
            break;
        else {
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            std::cout << "Należy wprowadzić liczbę całkowitą dodatnią" << std::endl;
        }
    }
    return number;
}

int main() {
    int a = readNumber("a");
    int b = readNumber("b");
    int gcd_a_b = gcd(a, b);
    std::cout << "Największy wspólny dzielnik liczb " << a << " i " << b << " to " << gcd_a_b << "." << std::endl;
    return 0;
}