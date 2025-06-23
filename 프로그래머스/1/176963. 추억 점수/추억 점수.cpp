#include <iostream>
#include <vector>
#include <string>
#include <map>
using namespace std;

vector<int> solution(vector<string> name, vector<int> yearning, vector<vector<string>> photo) {
    map<string, int> scoreMap;
    vector<int> answer;

    for (size_t i = 0; i < name.size(); ++i) {
        scoreMap[name[i]] = yearning[i];
    }

    for (const auto& pic : photo) {
        int sum = 0;
        for (const auto& person : pic) {
            if (scoreMap.count(person)) {
                sum += scoreMap[person];
            }
        }
        answer.push_back(sum);
    }

    return answer;
}