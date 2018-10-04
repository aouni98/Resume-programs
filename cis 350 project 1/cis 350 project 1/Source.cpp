#include<iostream>
#include<vector>
#include<algorithm>
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


class Graph
{
public:
	Graph(int size)
	{
		Matrix<char> graph(size, size);
		vector <char> temp(size);
		adj = graph;
		order = temp;
	}
	// creates an empty graph with size vertices
	void fillGraph()
	{
		
		for (int i = 0; i < adj.numcols(); i++)
		{
			int var;
			cin >> adj[i][0];
			order[i] = adj[i][0];
			cin >> var;
				for (int j = 1; j <= var; j++)
				{
					cin >> adj[i][j];
				}
		}
	}// fills in the graph from cin
	void printGraph()
	{
		for (int i = 0; i < adj.numrows(); i++)
		{
			for (int j = 0; j < adj.numcols(); j++)
			{

				cout << adj[i][j];
			}
			cout << endl;
		}
	}// prints the graph (for debugging only)
	int maxCover(vector<char> order); // returns the maxCover for the
	// ordering order
	int cover(char vertex)
	{
		int cover = 0;
		int tempcov = 0;
		for (int i = 0; i < order.capacity(); i++)
		{
			if (order[i] == vertex)
			{
				for (int j = 1; j < adj.numcols(); j++)
				{
					for (int z = 0; z < order.capacity(); z++)
					{
						if (adj[i][j] == order[z])
						{
							 tempcov = abs(i - z);
								if (tempcov > cover)
								{
									cover = tempcov;
								}
						}
					}
				}
			}
		}
		return cover;
	}// returns the cover size for vertex
private:
	Matrix<char> adj;
	vector<char> order;
};
// from Data Structures and Algorithm Analysis in C++ (Third Edition), by Mark Allen Weiss

int main(){
	int var;
	Graph graph1(8);
	graph1.fillGraph();
	graph1.printGraph();
	cout << graph1.cover('A');
	cout << graph1.cover('B'); 
	cout << graph1.cover('C');
	cout << graph1.cover('D');
	cout << graph1.cover('E');
	cout << graph1.cover('F');
	cout << graph1.cover('G');
	cout << graph1.cover('H');
	return 0;
}