#include <string>
#include <cctype>
using namespace std;

bool solution(string s) {
    int pCount = 0;
    int yCount = 0;

    for (char c : s) {
        c = tolower(c);
        if (c == 'p') pCount++;
        else if (c == 'y') yCount++;
    }

    return pCount == yCount;
}
