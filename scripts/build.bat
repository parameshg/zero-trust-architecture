@echo off
docker build -t parameshg/zerotrust-prototype-backend-api:latest -f ../backend/Dockerfile ../backend
docker build -t parameshg/zerotrust-prototype-frontend-api:latest -f ../frontend/Dockerfile ../frontend