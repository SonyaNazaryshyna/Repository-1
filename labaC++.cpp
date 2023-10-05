#include <iostream>
#include <string>

using namespace std;

int main() {
    int price[] = {25, 30, 47, 80};
    string productName[] ={"bread", "tea", "Chocolate", "Coffee"};
    for(int i = 0; i < 4; i++) {
    cout << "product:" << productName[i] << endl;
    cout << "price:" << price[i] << "uah" << endl;
    }
    return 0;
}