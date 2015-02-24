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
	float current_water = water;
	int count = tetrahedrons.size();
	float curr_vol;
	bool can_fill = true;
	int min = tetrahedrons[0];
	int filled = 0;
	int min_pos = 0;


	for (int i = 0; i < count; i++)
	{
		for (int j = 0; j < count; j++)
		{
			if (tetrahedrons[j] <= min && tetrahedrons[j] != 0)
			{
				min = tetrahedrons[j];
				min_pos = j;
			}			
		}
		curr_vol = fill_tetrahedron(min);
		if (current_water < curr_vol)
		{
			return filled;
		}
		else
		{
			current_water -= curr_vol;
			filled++;
		}
		tetrahedrons[min_pos] = 0;
		if (tetrahedrons[0] == 0)
		{
			min = tetrahedrons[1];
		}
		else
		{
			min = tetrahedrons[0];
		}
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

	int filled = tetrahedrons_filled(tetrahedrons, 10);

	cout << filled << endl;

	system("pause");
	return 0;
}