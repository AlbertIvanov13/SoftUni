from project.user import User

class Library:
    def __init__(self):
        self.user_records: list[User] = []
        self.books_available: dict = {}
        self.rented_books: dict = {}

    def get_book(self, author: str, book_name: str,
                 days_to_return: int, user: User) -> str:
        available_books = self.books_available.get(author, [])

        if book_name in available_books:
            user_rentals = self.rented_books.setdefault(user.username, {})
            user_rentals[book_name] = days_to_return
            user.books.append(book_name)
            available_books.remove(book_name)
            return f"{book_name} successfully rented for the next {days_to_return} days!"

        for user_rentals in self.rented_books.values():
            if book_name in user_rentals:
                days = user_rentals[book_name]
                return (
                    f'The book "{book_name}" is already rented '
                    f'and will be available in {days} days!'
                )

        return f'The book "{book_name}" is not available!'

    def return_book(self, author: str, book_name: str, user: User) -> str | None:
        user_rentals = self.rented_books.get(user.username, {})

        if book_name not in user_rentals:
            return f"{user.username} doesn't have this book in his/her records!"

        user.books.remove(book_name)
        del user_rentals[book_name]
        self.books_available.setdefault(author, []).append(book_name)
        return None