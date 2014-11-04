#include <iostream>

using namespace std;

int main()
{
	int first, second, temp;
	cin >> first >> second;

	while (second != 0)
	{
		temp = second;
		second = first % second;
		first = temp;
	}

	cout << first;

	system("pause");
	return 0;
}