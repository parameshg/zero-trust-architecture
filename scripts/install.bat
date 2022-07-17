@echo off
kubectl config use-context docker-desktop

kubectl apply -f ../infrastructure/namespace.yml
kubectl apply -f ../infrastructure/consul.yml
kubectl apply -f ../infrastructure/vault.yml
timeout 30

kubectl apply -f ../api/backend.yml
kubectl apply -f ../api/frontend.yml
timeout 30

kubectl get all -n zta

echo Execute following commands to forward ports from frontend (tcp/8080) and backend (tcp/8090)
echo * kubectl port-forward service/frontend-dapr 8080:80 -n dapr
echo * kubectl port-forward service/backend-dapr 8090:80 -n dapr