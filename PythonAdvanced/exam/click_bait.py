from collections import deque

suggested_links = deque([int(x) for x in input().split()])
featured_articles = list([int(x) for x in input().split()])
target_engagement_value = int(input())

final_feed = []

while suggested_links and featured_articles:
    first_element = suggested_links.popleft()
    last_element = featured_articles.pop()

    if first_element > last_element:
        remainder = first_element % last_element
        final_feed.append(-remainder)
        if remainder == 0:
            continue
        suggested_links.append(remainder * 2)
    elif last_element > first_element:
        remainder = last_element % first_element
        final_feed.append(+remainder)
        if remainder == 0:
            continue
        featured_articles.append(remainder * 2)
    elif first_element == last_element:
        final_feed.append(0)

total_engagement_value = sum(final_feed)

print(f"Final Feed: {', '.join(map(str, final_feed))}")
if total_engagement_value >= target_engagement_value:
    print(f"Goal achieved! Engagement Value: {total_engagement_value}")
else:
    print(f"Goal not achieved! Short by: {target_engagement_value - total_engagement_value}")