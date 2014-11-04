#include <iostream>
#include <time.h>
#include <cmath>

using namespace std;

int main()
{
	int centre_x;
	int centre_y;
	int coord_x;
	int coord_y;
	int radius;
	int square_side;

	srand(time(NULL));

	centre_x = rand() % 100 + 1;
	centre_y = rand() % 100 + 1;
	radius = rand() % 150 + 1;
	square_side = radius;

	cin >> coord_x >> coord_y;

	if (coord_x >= (centre_x + square_side) || coord_y >= (centre_y + square_side))
	{
		cout << "Out of bounds";
	}
	else
	{
		if ((pow((coord_x - centre_x), 2) + pow((coord_y - centre_y), 2)) > radius * radius)
		{

		}
	}

}