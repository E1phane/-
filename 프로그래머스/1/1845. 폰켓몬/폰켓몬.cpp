#include <vector>
#include <unordered_set>
using namespace std;

int solution(vector<int> nums)
{
    int selectCount = nums.size() / 2;

    unordered_set<int> uniqueKinds(nums.begin(), nums.end());

    int answer = min((int)uniqueKinds.size(), selectCount);

    return answer;
}
