from sqlalchemy import create_engine, Column, Integer, String, ForeignKey
from sqlalchemy.orm import relationship, sessionmaker, joinedload
from sqlalchemy.ext.declarative import declarative_base

Base = declarative_base()

class User(Base):
    __tablename__ = 'users'
    
    id = Column(Integer, primary_key=True, autoincrement=True)
    username = Column(String, nullable=False)
    
    orders = relationship('Order', back_populates='user')

class Order(Base):
    __tablename__ = 'orders'
    
    id = Column(Integer, primary_key=True, autoincrement=True)
    product_name = Column(String, nullable=False)
    product_count = Column(Integer, nullable=False)
    user_id = Column(Integer, ForeignKey('users.id'), nullable=False)
    
    user = relationship('User', back_populates='orders')

engine = create_engine('sqlite:///lab7.db', echo=True)

Base.metadata.create_all(engine)

Session = sessionmaker(bind=engine)
session = Session()

def add_sample_data():
    user1 = User(username='Daniil')
    user2 = User(username='Peter')
    user3 = User(username='Alex')
    
    order1 = Order(product_name='Macbook 13', product_count=1, user=user1)
    order2 = Order(product_name='IPhone 15 Pro MAX', product_count=2, user=user1)
    order3 = Order(product_name='Sumsung', product_count=1, user=user2)
    order4 = Order(product_name='Xbox', product_count=1, user=user3)
    
    session.add(user1)
    session.add(user2)
    session.add(user3)
    session.add(order1)
    session.add(order2)
    session.add(order3)
    session.add(order4)
    
    session.commit()


def get_users():
    users = session.query(User).all()
    for user in users:
        print(f'User: {user.username}')

def get_users_with_orders():
    users = session.query(User).options(joinedload(User.orders)).all()
    for user in users:
        print(f'User: {user.username}')
        print('Orders:')
        for order in user.orders:
            print(f'- Product: {order.product_name}, Count: {order.product_count}')

def main():
    if session.query(User).count() == 0:
        add_sample_data()
    
    get_users()
    get_users_with_orders()

if __name__ == "__main__":
    main()