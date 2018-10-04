#include<iostream>
#include<vector>


using namespace std;

struct Node
{
	int id;
	int minRequests4Raise;
	vector< Node *> underlings;
	Node(int n = 0);

};


class Tree
{
private:
	Node * root;
	void print(Node * ptr, int level);
	Node * find(Node * root, int target);
public:
	Tree(Node * rt = nullptr) { root = rt; }
	Tree(int id);
	Node * getRoot();
	void printTree();
	Node * find(int target);
};

class Forest
{
private:
	vector< Tree > trees;
public:
	void print();
	Node * find(int target);
	void insert(int boss, int underling);
	Forest();
	void clear();
};

int main()
{

	return 0;
}

