import math
def fill_tetrahedron(num):
	formula = math.sqrt(2.0) * (num**3.0)/12
	volume = formula / 1000
	return volume

print fill_tetrahedron(100)

def tetrahedrons_filled(tetrahedrons, water):
	tetrahedrons.sort()
	current_water = water
	filled = 0
	for item in tetrahedrons:
		if current_water >= fill_tetrahedron(item):
			current_water -= fill_tetrahedron(item)
			filled += 1
		else:
			return filled

print tetrahedrons_filled([100, 20, 30, 78, 49], 100)