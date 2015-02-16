#include <iostream>
#include <cmath>

using namespace std;

float fill_tetrahedron(int num)
{
	float formula = sqrt(2.0) * pow((float)num, 3.0) / 12;
	float volume = formula / 1000;

	return volume;
}

int main()
{
	int num;
	cin >> num;
	float volume = fill_tetrahedron(num);
	cout << volume << endl;

	system("pause");
	return 0;
}