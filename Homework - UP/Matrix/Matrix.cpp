#include <iostream>

using namespace std;

int main()
{
	int size;
	int number = 1;
	cin >> size;

	for (int i = 0; i < size; i++)
	{
		cout << endl;
		for (int i = 0; i < size; i++)
		{
			cout << number << "   ";
			number++;
		}
	}

	cout << endl;

	system("pause");
	return 0;
}