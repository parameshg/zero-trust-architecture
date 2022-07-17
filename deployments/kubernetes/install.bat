@echo off
REM Prepare Environment
kubectl config use-context docker-desktop
kubectl apply -f namespace.yml

REM Install Consul into Kubernetes using Helm
helm repo add hashicorp https://helm.releases.hashicorp.com
helm install consul hashicorp/consul --set global.name=consul --namespace consul --values consul.yml
timeout 60
kubectl get all -n consul

REM Install Application into Kubernetes using CLI
kubectl apply -f defaults.yml
kubectl apply -f backend.yml
kubectl apply -f frontend.yml
timeout 30
kubectl get all -n prototype

REM Display Helper Commands
echo ===================================================================================================================
echo Execute following commands to forward ports from consul ui (tcp/8500), frontend (tcp/8080) and backend (tcp/8090)
echo * kubectl port-forward service/consul-server -n consul 8500:8500
echo * kubectl port-forward service/frontend 8080:80 -n prototype
echo * kubectl port-forward service/backend 8090:80 -n prototype