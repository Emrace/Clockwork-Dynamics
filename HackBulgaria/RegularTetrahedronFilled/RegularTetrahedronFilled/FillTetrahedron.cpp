#include <iostream>
#include <cmath>
#include <vector>

using namespace std;

float fill_tetrahedron(int num)
{
	float formula = sqrt(2.0) * pow((float)num, 3.0) / 12;
	float volume = formula / 1000;

	return volume;
}

int tetrahedrons_filled(vector<int>& tetrahedrons, int water)
{
	double current_water = water;
	int count = tetrahedrons.size();
	vector<int> volumes(count);
	bool can_fill = true;
	int min = 0;
	int filled = 0;
	int min_pos = 0;

	for (int i = 0; i < count; i++)
	{
		volumes[i] = fill_tetrahedron(tetrahedrons[i]);
	}

	min = volumes[0];
	while (can_fill)
	{

		for (int i = 0; i < count; i++)
		{
			if (volumes[i] < min)
			{
				min = volumes[i];
				min_pos = i;
			}
		}

		if (current_water < min)
		{
			can_fill = false;
		}
		else
		{			
			current_water -= min;
			filled++;
		}

		volumes.erase(volumes.begin() + min_pos - 1);
		min = volumes[0];
	}
	return filled;
}

int main()
{
	int num;
	cin >> num;
	float volume = fill_tetrahedron(num);
	cout << volume << endl;

	int size = 3;
	int water = 0;
	vector<int> tetrahedrons(size);
	tetrahedrons[0] = 100;
	tetrahedrons[1] = 20;
	tetrahedrons[2] = 30;
	/*cin >> size;
	cin >> water;

	for (int i = 0; i < size; i++)
	{
		cin >> tetrahedrons[i];
	}
	*/

	int filled = tetrahedrons_filled(tetrahedrons, 10);

	cout << filled << endl;

	system("pause");
	return 0;
}