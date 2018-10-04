//Aouni Halaweh
//This program takes a set of points representing a set of pokemon. Starting and ending at the point (0,0) 
//the code takes the points and determines the shortest path to get all unique pokemon. the input first is an int representing the number of  points,
// the format for each point will be( x y name ) once they are all entered the output which is the distance f the shortest path will be printed on screen. 
#include<iostream>
#include<vector>
#include<cmath>
#include<algorithm>
#include<string>
#include<queue>


using namespace std;

template <class Object>
class Matrix
{
public:
	Matrix(int rows = 0, int cols = 0) : array(rows)
	{
		for (int i = 0; i < rows; i++)array[i].resize(cols);
	}
	void resize(int rows, int cols)
	{
		array.resize(rows);
		for (int i = 0; i < rows; i++)array[i].resize(cols);
	}
	const vector<Object> & operator[](int row) const
	{
		return array[row];
	}
	vector<Object> & operator[](int row)
	{
		return array[row];
	}
	int numrows() const
	{
		return array.size();
	}
	int numcols() const
	{
		return numrows() ? array[0].size() : 0;
	}
private:
	vector< vector<Object> > array;
};
struct pokeStop
{
	int id;
	string name;
	int x;
	int y;

};
bool stringFind(string & pokename, vector <string> & vect)
{
	for (int i = 0; i < vect.size(); i++)
	{
		if (pokename == vect[i])
			return 1;
		if (vect[i] == "")
			return 0;

	}           
	return 0;
}

bool intFind(pokeStop & pokeId, vector <int> & vect)
{
	for (int i = 0; i < vect.size(); i++)
	{
		if (pokeId.id == vect[i])
			return 1;
		if (vect[i] == -1)
			return 0;

	}
	return 0;
}

class pokeNode
{
public:
	int lastPath;
	int lowerBound;
	int currentDist;
	vector <string> visited;
	vector <int> path;
		pokeNode() {};
	pokeNode(int vectsize) 
	{
		size = vectsize + 1;
		path.resize(vectsize,-1);
		visited.resize(vectsize - 1);
	}
	
	void insVisited(string name)
	{
		if (visited.size() == 0)
		{
			visited.resize(1);
		}
	
		for (int i = 0; i < visited.size(); i++)
		{
			if (visited[i] == "")
			{
				visited.insert((visited.begin() + i), name);
				visited.resize(size);
				return;
			}
		}
		
	}

	void insPath(int num)
	{
		lastPath = num;
		for (int i = 0; i < path.size(); i++)
		{
			if (path[i] == -1)
			{
				path.insert((path.begin()+ i ),num);
				path.resize(size );
				return;
			}
		}
		
	}
	void calcCurrentDist(Matrix <int> & pokeGraph)
	{
		int temp = 0;
		for (int i = 0; i < path.size() - 1; i++)
		{
			if(path[i+1] != -1)
			temp = pokeGraph[path[i]][path[i + 1]] + temp;
		}
		currentDist = temp;
	}

void calcLowerbound(vector<pokeStop> & pokeVect, Matrix <int> & pokeGraph)
{	
int tempLower = currentDist;
for (int i = 0; i < pokeVect.size(); i++)
{    
int temp = INT_MAX;
			
if (!stringFind(pokeVect[i].name, visited) || pokeVect[i].name == lastVisited)
{
for (int j = 0; j < pokeVect.size(); j++)
{
if (pokeGraph[i][j] < temp)
temp = pokeGraph[i][j];
}
if (temp != INT_MAX)
tempLower += temp;
}	
}
lowerBound = tempLower;
}

	bool operator < (const pokeNode & lhs) const
	{
		return lowerBound > lhs.lowerBound;
	};

	bool operator = (const pokeNode & lhs)
	{
		
		lastVisited = lhs.lastVisited;
		lastPath = lhs.lastPath;
		size = lhs.size;
		lowerBound = lhs.lowerBound;
		currentDist = lhs.currentDist;
		visited = lhs.visited;
		path = lhs.path;
		return 1;
	};

private:
	
	
	int size;
	string lastVisited;
};


void fillGraph(vector<pokeStop > & pokeVect , Matrix <int> & pokeGraph)
{
	
	for (int i = 0; i < pokeVect.size(); i++)
	{
		for (int j = 0; j < pokeVect.size(); j++)
		{	int distance = INT_MAX;
			if (i != j)
			{
				distance = (abs(pokeVect[i].x - pokeVect[j].x) + abs(pokeVect[i].y - pokeVect[j].y));
			}
				pokeGraph[i][j] = distance;
		}
	}

}

pokeNode bestPath(Matrix<int> & pokeGraph, vector <pokeStop > & pokeVect, int & numStops, priority_queue <pokeNode> & pokeQue)
{

	int lowestBound = 0;



	pokeNode top = pokeQue.top();
	if (top.path.back() == 0 && top.path.size() > 1)
	{
		return top;
	}
	pokeQue.pop();
		for (int i = 0; i < pokeVect.size(); i++)
		{
			pokeNode temp = top;
			
			if (find(temp.visited.begin(),temp.visited.end(),pokeVect[i].name) == temp.visited.end())
			{
				temp.insPath(i);
				temp.insVisited(pokeVect[i].name);
				temp.calcCurrentDist(pokeGraph);
				temp.calcLowerbound(pokeVect, pokeGraph);
				pokeQue.push(temp);
			}
		}
	
		if (pokeQue.size() == 0)
		{
			return top;
		}
		
	
	return pokeQue.top();
}

int main()
{
	int numStops;
	cin >> numStops;
	numStops += 1;
	vector<int> pathKey(numStops + 1);
	Matrix <int> pokeGraph(numStops,numStops) ;
	vector <pokeStop> pokeVect(numStops);
	vector <string> fullVisited(numStops);
	pokeStop tempOrigin;
		tempOrigin.id = 0;
		tempOrigin.x = 0;
		tempOrigin.y = 0;
		tempOrigin.name = "origin";
		fullVisited[0] = "origin";
		pokeVect[0] = tempOrigin;

	for (int i = 1; i < numStops; i++)
	{
		pokeStop temp;
		temp.id = i;
		cin >> temp.x;
		cin >> temp.y;
		cin >> temp.name;
		fullVisited[i] = temp.name;
		pokeVect[i] = temp;
	}

	fillGraph(pokeVect, pokeGraph);
	
	priority_queue <pokeNode> pokeQue;
	pokeNode origin(numStops);
	origin.insPath(0);
	origin.insVisited(pokeVect[0].name);
	pokeQue.push(origin);

	for (int i = 0; i < fullVisited.size(); i++)
	{
		for (int j = 0; j < fullVisited.size(); j++)
		{
			if (i != j) 
			{
				if (fullVisited[i] == fullVisited[j])
					fullVisited.erase(fullVisited.begin() + j);
			}
		}
	}

	sort(fullVisited.begin(), fullVisited.end());
	vector <int> checkPath;
	vector <string> check;
	pokeNode clear;
	pokeNode temp;
	int lastpathpos;
	temp = pokeQue.top();
	checkPath = temp.path;
	while (checkPath.back() != 0 || checkPath.size() == 1)
	{
		check.clear();
		temp = clear;
		temp = bestPath(pokeGraph, pokeVect, numStops, pokeQue);
		check = temp.visited;
		for (int i = 0; i < check.size(); i++)
		{
			if (check[i] == "")
				check.erase(check.begin() + i, check.end());
		}
		sort(check.begin(), check.end());
		if (check == fullVisited)
		{
			temp.insPath(0);
			temp.insVisited(pokeVect[0].name);
			temp.calcCurrentDist(pokeGraph);
			temp.calcLowerbound(pokeVect, pokeGraph);
			pokeQue.push(temp);
			temp = clear;
			temp = pokeQue.top();
		}
		checkPath = temp.path;
		for (int i = 0; i < checkPath.size(); i++)
		{
			if (checkPath[i] == -1)
				checkPath.erase(checkPath.begin() + i, checkPath.end());
		}
	}

	if (temp.lowerBound == INT_MAX)
	{
		cout << "0";
	}
	else
	{
		cout << temp.currentDist;
	}
	system("pause");

	return 0;
}